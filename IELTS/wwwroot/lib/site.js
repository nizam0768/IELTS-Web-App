window.blazorInterop = window.blazorInterop || {};

window.blazorInterop.applyDataTable = function (tableId) {
    setTimeout(() => {
        const table = document.getElementById(tableId);
        if (table) {
            $('#' + tableId).DataTable({
                order: [[0, 'asc']],
                scrollX: true,
                paging: true,
                info: true,
                columnDefs: [
                    { width: '15%', targets: 0 },
                    { width: '10%', targets: 1 },
                    { width: '15%', targets: 2 },
                    { width: '40%', targets: 3 },
                    { width: '20%', targets: 4 }
                ]
            });
        }
    });
};

// Reading Section jQuery Enhancements
$(document).ready(function() {
    
    // Smooth scrolling for navigation
    $('a[href^="#"]').on('click', function(event) {
        var target = $(this.getAttribute('href'));
        if (target.length) {
            event.preventDefault();
            $('html, body').stop().animate({
                scrollTop: target.offset().top - 100
            }, 1000);
        }
    });
    
    // Practice test card hover effects
    $(document).on('mouseenter', '.practice-test-card', function() {
        $(this).addClass('shadow-lg');
    });
    
    $(document).on('mouseleave', '.practice-test-card', function() {
        $(this).removeClass('shadow-lg');
    });
    
    // Question input focus effects
    $(document).on('focus', '.form-control, .form-select', function() {
        $(this).closest('.card').addClass('border-primary');
    });
    
    $(document).on('blur', '.form-control, .form-select', function() {
        $(this).closest('.card').removeClass('border-primary');
    });
    
    // Auto-save functionality for answers (optional)
    $(document).on('change input', '.form-control, .form-select, .form-check-input', function() {
        const questionId = $(this).attr('id') || $(this).attr('name');
        if (questionId) {
            // Add visual feedback for answered questions
            $(this).closest('.card').addClass('question-answered').removeClass('question-unanswered');
            
            // Add checkmark icon to indicate completion
            let checkIcon = $(this).closest('.card').find('.answer-status');
            if (checkIcon.length === 0) {
                $(this).closest('.card-header, .card-body').first().append(
                    '<i class="fas fa-check-circle text-success answer-status" style="position: absolute; top: 10px; right: 10px;"></i>'
                );
            }
        }
    });
    
    // Tab switching enhancements
    $(document).on('shown.bs.tab', 'a[data-bs-toggle="tab"]', function (e) {
        // Smooth scroll to top of tab content
        const target = $($(this).attr('data-bs-target'));
        if (target.length) {
            target.get(0).scrollIntoView({ behavior: 'smooth', block: 'start' });
        }
    });
    
    // Progress bar animations
    function animateProgressBar() {
        $('.progress-bar').each(function() {
            const $this = $(this);
            const width = $this.attr('aria-valuenow');
            $this.css('width', '0%').animate({
                width: width + '%'
            }, 1000);
        });
    }
    
    // Call progress bar animation when results are shown
    $(document).on('DOMNodeInserted', '.progress', function() {
        setTimeout(animateProgressBar, 100);
    });
    
    // Accordion enhancements
    $(document).on('show.bs.collapse', '.accordion-collapse', function() {
        $(this).parent().addClass('active');
    });
    
    $(document).on('hide.bs.collapse', '.accordion-collapse', function() {
        $(this).parent().removeClass('active');
    });
    
    // Timer warning effects
    function checkTimerWarning() {
        const timerElement = $('[style*="color: #f44336"]');
        if (timerElement.length > 0) {
            timerElement.addClass('timer-critical');
            // Add pulsing effect to submit button when time is critical
            $('.btn-outline-danger, .btn-success').addClass('btn-pulse');
        }
    }
    
    // Check timer every second
    setInterval(checkTimerWarning, 1000);
    
    // Question type specific enhancements
    $(document).on('change', 'input[type="radio"]', function() {
        // Clear other radio buttons in the same group
        const name = $(this).attr('name');
        $(`input[name="${name}"]`).closest('.form-check').removeClass('selected');
        $(this).closest('.form-check').addClass('selected');
    });
    
    // Form validation feedback
    $(document).on('invalid', '.form-control, .form-select', function() {
        $(this).addClass('is-invalid');
        $(this).closest('.card').addClass('border-danger');
    });
    
    $(document).on('input change', '.form-control, .form-select', function() {
        if (this.checkValidity()) {
            $(this).removeClass('is-invalid').addClass('is-valid');
            $(this).closest('.card').removeClass('border-danger').addClass('border-success');
        }
    });
    
    // Keyboard shortcuts
    $(document).on('keydown', function(e) {
        // Ctrl+Enter to submit test
        if (e.ctrlKey && e.keyCode === 13) {
            $('.btn-success[onclick*="SubmitTest"], .btn-outline-danger[onclick*="SubmitTest"]').click();
        }
        
        // Arrow keys for section navigation
        if (e.altKey) {
            if (e.keyCode === 37) { // Alt + Left Arrow
                $('.btn[onclick*="PreviousSection"]').click();
            } else if (e.keyCode === 39) { // Alt + Right Arrow
                $('.btn[onclick*="NextSection"]').click();
            }
        }
    });
    
    // Tooltip initialization for better UX
    function initializeTooltips() {
        $('[data-bs-toggle="tooltip"]').tooltip();
    }
    
    // Initialize tooltips when DOM changes
    $(document).on('DOMNodeInserted', function() {
        setTimeout(initializeTooltips, 100);
    });
    
    // Reading passage highlighting (optional feature)
    $(document).on('mouseup', '.reading-passage', function() {
        const selection = window.getSelection();
        if (selection.toString().length > 0) {
            // Could add highlighting functionality here
            console.log('Text selected:', selection.toString());
        }
    });
    
    // Auto-resize text areas if any
    $(document).on('input', 'textarea', function() {
        this.style.height = 'auto';
        this.style.height = (this.scrollHeight) + 'px';
    });
    
    // Loading state management
    window.showLoading = function() {
        $('body').append('<div class="loading-overlay"><div class="loading-spinner"></div></div>');
    };
    
    window.hideLoading = function() {
        $('.loading-overlay').remove();
    };
    
    // Print functionality for results
    window.printResults = function() {
        window.print();
    };
    
});

// CSS for additional enhancements
const additionalCSS = `
    .btn-pulse {
        animation: pulse-button 1s infinite;
    }
    
    @keyframes pulse-button {
        0% { transform: scale(1); }
        50% { transform: scale(1.05); }
        100% { transform: scale(1); }
    }
    
    .form-check.selected {
        background-color: rgba(13, 110, 253, 0.1);
        border-radius: 0.375rem;
        padding: 0.25rem;
    }
    
    .loading-overlay {
        position: fixed;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        background: rgba(255, 255, 255, 0.8);
        display: flex;
        justify-content: center;
        align-items: center;
        z-index: 9999;
    }
    
    .accordion-item.active {
        box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    }
    
    .answer-status {
        animation: fadeIn 0.3s ease-in-out;
    }
    
    @media print {
        .btn, .nav-tabs, .accordion-button {
            display: none !important;
        }
    }
`;

// Inject additional CSS
const style = document.createElement('style');
style.textContent = additionalCSS;
document.head.appendChild(style);
